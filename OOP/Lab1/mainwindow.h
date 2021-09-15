#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

public slots:
    void animate();

private:
    Ui::MainWindow *ui;

    const int a = 11;
    int x = 0;
    int y = 0;

    QPointF circleCoordinates = QPointF(855, 25);
    const float circleRadius = 15;

    QPointF *rectangleCoordinates = new QPointF[3] {
        QPointF(830, 80), QPointF(880, 80), QPointF(855, 40)
    };

    void paintEvent(QPaintEvent *paintEvent) override;
    void printLabworkNameVertically();

    void updateParameters();
    bool finish();
    void dropParameters();

    void dropCoordinates();
    void dropRectangleCoordinates();
    void dropCircleCoordinates();

    float calculateDiocleCissoid();

    void updateCoordinates();
    void updateRectangleCoordinates();
    void updateCircleCoordinates();

    void drawTriangle();
    void drawCircle();
};
#endif // MAINWINDOW_H
