#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QPainter>
#include <QTimer>
#include <cmath>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    setFixedSize(900, 900);
    auto timer = new QTimer(this);
    connect(timer, SIGNAL(timeout()), this, SLOT(animate()));
    timer->start(50);
}

void MainWindow::animate() {
    repaint();
}

void MainWindow::paintEvent(QPaintEvent *event) {
    printLabworkNameVertically();
    updateParameters();
    updateCoordinates();
    drawTriangle();
    drawCircle();
}

void MainWindow::printLabworkNameVertically() {
    QPainter painter(this);
    QFont font ("Helvetica");
    font.setWeight(QFont::ExtraLight);
    painter.setFont(font);
    painter.save();

    painter.translate(20, 450);
    painter.rotate(-90);
    painter.drawText(0, 0, QString::fromStdString("Графичиские примитивы в фреймоврке Qt"));
    painter.restore();
}

void MainWindow::updateParameters() {
    rectangleCoordinates[0].y() < 300 ? x-- : x++;
    y = calculateDiocleCissoid();
}

float MainWindow::calculateDiocleCissoid() {
    return 8 * pow(a, 3) / (pow(x, 2) + 4 * pow(a, 2));
}

void MainWindow::updateCoordinates() {
    if (finish()) {
        dropParameters();
        dropCoordinates();
    }
    updateRectangleCoordinates();
    updateCircleCoordinates();
}

bool MainWindow::finish() {
    return rectangleCoordinates[0].y() > 800 ? true : false;
}

void MainWindow::dropParameters() {
    x = 0;
    y = 0;
}

void MainWindow::dropCoordinates() {
    dropRectangleCoordinates();
    dropCircleCoordinates();
}

void MainWindow::dropRectangleCoordinates() {
    rectangleCoordinates = new QPointF[3] {
        QPointF(830, 80), QPointF(880, 80), QPointF(855, 40)
    };
}

void MainWindow::dropCircleCoordinates() {
    circleCoordinates = QPointF(855, 25);
}

void MainWindow::updateRectangleCoordinates() {
    QPointF offset = QPointF(x, y);
    for (int i = 0; i < 3; i++)
        rectangleCoordinates[i] += offset;
}

void MainWindow::updateCircleCoordinates() {
    QPointF offset = QPointF(x, y);
    circleCoordinates += offset;
}

void MainWindow::drawTriangle() {
    QPainter painter(this);
    painter.drawPolygon(rectangleCoordinates, 3);
    painter.restore();
}

void MainWindow::drawCircle() {
    QPainter painter(this);
    painter.drawEllipse(circleCoordinates, circleRadius, circleRadius);
    painter.restore();
}


MainWindow::~MainWindow() {
    delete ui;
    delete[] rectangleCoordinates;
}

