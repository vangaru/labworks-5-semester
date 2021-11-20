#include "texteditor.h"
#include "ui_texteditor.h"
#include "QCloseEvent"
#include "QMessageBox"
#include "QFontDialog"
#include "QSettings"
#include "QTextStream"
#include "QFileInfo"
#include "QFileDialog"
#include <stdexcept>

TextEditor::TextEditor(QWidget *parent, const QString &fileName)
    : QMainWindow(parent)
    , ui(new Ui::TextEditor)
{
    ui->setupUi(this);

    ui->actionCopy->setEnabled(false);
    ui->actionCut->setEnabled(false);
    ui->actionRedo->setEnabled(false);
    ui->actionUndo->setEnabled(false);

    QFont Font = QSettings(this).value("VIEW").value<QFont>();
    ui->textEdit->setFont(Font);

    connect(ui->textEdit, SIGNAL(textChanged()), this, SLOT(ondocumentModified()));

    connect(ui->textEdit, SIGNAL(copyAvailable(bool)), ui->actionCut, SLOT(setEnabled(bool)));
    connect(ui->textEdit, SIGNAL(copyAvailable(bool)), ui->actionCopy, SLOT(setEnabled(bool)));
    connect(ui->textEdit, SIGNAL(undoAvailable(bool)), ui->actionUndo, SLOT(setEnabled(bool)));
    connect(ui->textEdit, SIGNAL(redoAvailable(bool)), ui->actionRedo, SLOT(setEnabled(bool)));

    connect(ui->actionSave, SIGNAL(triggered()), this, SLOT(saveFile()));
    connect(ui->actionSaveAs, SIGNAL(triggered()), this, SLOT(saveFileAs()));

    loadFile(fileName);
}

TextEditor::~TextEditor()
{
    delete ui;
}

void TextEditor::on_actionNew_triggered()
{
    TextEditor *t = new TextEditor();
    t->show();
}

void TextEditor::on_actionClose_triggered()
{
    close();
}

void TextEditor::on_actionExit_triggered()
{
    qApp->closeAllWindows();
}

void TextEditor::ondocumentModified()
{
    setWindowModified(true);
}

void TextEditor::closeEvent(QCloseEvent *e)
{
    if (isWindowModified())
        {
            switch (QMessageBox::warning(this, "Document Modified",
               "Данные документа были измененны. \n"
               "Вы хотите сохранить изменения?\n"
               "Все несохраненные данные будут утеряны.",
               QMessageBox::Yes | QMessageBox::No | QMessageBox::Cancel,
               QMessageBox::Cancel))
            {
            case QMessageBox::Yes:
                saveFile();
                e->ignore();
                break;
            case QMessageBox::No:
                e->accept();
                break;
            case QMessageBox::Cancel:
                e->ignore();
                break;
            }
        }
        else
        {
            e->accept();
        }

}

void TextEditor::on_actionSelectFont_triggered()
{
    bool Changed;
    QFont newFont = QFontDialog::getFont(&Changed);
    if (Changed) {
        ui->textEdit->setFont(newFont);
        QSettings settings(this);
        settings.setValue("VIEWF", newFont);
    }
}

void TextEditor::on_actionAbout_triggered()
{
    QMessageBox::about(this, "About", "No info");
}

void TextEditor::on_actionAboutQT_triggered()
{
    qApp->aboutQt();
}

void TextEditor::on_actionCut_triggered()
{
    ui->textEdit->cut();
}

void TextEditor::on_actionCopy_triggered()
{
    ui->textEdit->copy();
}

void TextEditor::on_actionPaste_triggered()
{
    ui->textEdit->paste();
}

void TextEditor::on_actionUndo_triggered()
{
    ui->textEdit->undo();
}

void TextEditor::on_actionRedo_triggered()
{
    ui->textEdit->redo();
}

void TextEditor::on_actionOpen_triggered()
{
    QString fileName = QFileDialog::getOpenFileName(this,
        "Open document", QDir::currentPath(), "Text documents (*.txt)");
    if (fileName.isNull()) return;
    if (m_fileName.isNull() && !isWindowModified()) {
        loadFile(fileName);
    }
    else {
        TextEditor * p = new TextEditor(this, fileName);
        p->show();
    }
}

void TextEditor::loadFile(const QString &fileName)
{
    if (fileName.isEmpty()) {
        setFileName(QString());
        return;
    }
    else {
        QFile a(fileName);
        if(!a.open(QIODevice::ReadOnly | QIODevice::Text)){
            QMessageBox::warning(this, "Error", "File is not found");
            setFileName(QString());
            return;
        }
        QTextStream b(&a);
        ui->textEdit->setText(b.readAll());
        a.close();
        setFileName(fileName);
        setWindowModified(false);
    }
}

void TextEditor::setFileName(const QString &name) {
    m_fileName = name;
    setWindowTitle(QString("%1[*] - %2")
            .arg(m_fileName.isNull()?"lab2":QFileInfo(m_fileName).fileName())
            .arg(QApplication::applicationName()));
}

bool TextEditor::saveFileAs(){
    QString fileName = QFileDialog::getSaveFileName(this, "Save document",
       m_fileName.isNull() ? QDir::currentPath() : m_fileName, "Text documents (*.txt)");
    if (fileName.isNull()) {
        return false;
    }
    else {
        setFileName(fileName);
        return saveFile();
    }
}

bool TextEditor::saveFile(){
    if (m_fileName.isNull()) {
        return saveFileAs();
    }
    else {
        QFile f(m_fileName);
        if(!f.open(QIODevice::WriteOnly | QIODevice::Text)){
            QMessageBox::warning(this, "File is not found", "File is not found");
            setFileName(QString());
            return false;
        }
        else {
            QTextStream a(&f);
            a << ui->textEdit->toPlainText();
            f.close();
            setWindowModified(false);
            return true;
        }
    }
}
