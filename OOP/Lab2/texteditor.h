#ifndef TEXTEDITOR_H
#define TEXTEDITOR_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui { class TextEditor; }
QT_END_NAMESPACE

class TextEditor : public QMainWindow
{
    Q_OBJECT

public:
    TextEditor(QWidget *parent = nullptr, const QString &fileName=QString());
    ~TextEditor();

protected:
    void closeEvent(QCloseEvent *e);
    void loadFile(const QString &fileName);

private slots:
    void on_actionNew_triggered();

    void on_actionClose_triggered();

    void on_actionExit_triggered();

    void ondocumentModified();

    void on_actionSelectFont_triggered();

    void on_actionCut_triggered();

    void on_actionAbout_triggered();

    void on_actionAboutQT_triggered();

    void on_actionCopy_triggered();

    void on_actionPaste_triggered();

    void on_actionUndo_triggered();

    void on_actionRedo_triggered();

    void on_actionOpen_triggered();

    bool saveFile();

    bool saveFileAs();

private:
    Ui::TextEditor *ui;

    QString m_fileName;

    void setFileName(const QString &);
};
#endif // TEXTEDITOR_H
