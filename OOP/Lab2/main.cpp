#include "texteditor.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    a.setApplicationName("Text editior");

    a.setWindowIcon(QIcon(":/icons/new.png"));

    TextEditor w;
    w.show();

    return a.exec();
}
