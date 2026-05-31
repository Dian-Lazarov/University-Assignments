#include <iostream>
using namespace std;

// дефиниране на константи за вместимостите (капацитетите) на чашите и търсената цел
const int X = 5;    // вместимост на чаша X
const int Y = 3;    // вместимост на чаша Y
const int Z = 4;    // цел

// структура, описваща едно състояние в ПС
struct State {
    int x;          // текущо количество вода в чаша X
    int y;          // текущо количество вода в чаша Y
    int parent_id; // индекс на състоянието-родител (за възстановяване на пътя)
};

// тъй като възможните състояния са малко (6 * 4 = 24), масив с размер 100 е напълно достатъчен
State statesQueue[100];
int qHead = 0; // указател към началото на опашката (текущия елемент, който обработваме)
int qTail = 0; // указател към края на опашката (за добавяне на нови елементи)

// двумерен масив за отбелязване на вече посетените състояния, за да избегнем безкрайни цикли
bool visited[X + 1][Y + 1];

// функция за добавяне на ново състояние в опашката, ако то не е посетено
void tryAddState(int nx, int ny, int parentIndex) {
    // защита от излизане извън граници
    if (nx >= 0 && nx <= X && ny >= 0 && ny <= Y) {
        // ако състоянието не е посетено
        if (!visited[nx][ny]) {
            visited[nx][ny] = true;             // маркираме го като посетено
            statesQueue[qTail].x = nx;          // записваме стойността за X
            statesQueue[qTail].y = ny;          // записваме стойността за Y
            statesQueue[qTail].parent_id = parentIndex; // записваме кой го е създал
            qTail++;                            // увеличаваме опашката
        }
    }
}

// рекурсивна функция за отпечатване на намерения път от началото до целта
void printPath(int targetIndex) {
    // дъно на рекурсията: ако сме стигнали до началното състояние (родител -1)
    if (targetIndex == -1) {
        return;
    }
    // извикваме рекурсията за родителя, за да се отпечатат първо предходните стъпки
    printPath(statesQueue[targetIndex].parent_id);

    // след като рекурсията се върне, отпечатваме текущата стъпка
    cout << "(" << statesQueue[targetIndex].x << ", " << statesQueue[targetIndex].y << ")" << endl;
}

// основен алгоритъм за търсене в ширина (BFS)
void solveBFS() {
    // инициализация на масива с посетени състояния с false
    for (int i = 0; i <= X; i++) {
        for (int j = 0; j <= Y; j++) {
            visited[i][j] = false;
        }
    }

    // добавяне на началното състояние (0, 0)
    visited[0][0] = true;
    statesQueue[qTail].x = 0;
    statesQueue[qTail].y = 0;
    statesQueue[qTail].parent_id = -1; // -1 означава, че това е началото
    qTail++;

    bool found = false;
    int goalIndex = -1;

    // цикълът се върти, докато опашката не се изпразни (qHead достигне qTail)
    while (qHead < qTail) {
        // вземаме текущото състояние от началото на опашката
        int currX = statesQueue[qHead].x;
        int currY = statesQueue[qHead].y;
        int currIndex = qHead; // индексът на текущото състояние, който ще стане родител на следващите
        qHead++;               // „премахваме“ елемента от опашката

        // проверка дали сме достигнали целта (4 единици в някоя от чашите)
        if (currX == Z || currY == Z) {
            found = true;
            goalIndex = currIndex;
            break; // прекратяваме търсенето при първото намерено решение (най-краткото)
        }

        // прилагане на операторите (генериране на наследници):

        // 1. напълване на X
        tryAddState(X, currY, currIndex);

        // 2. напълване на Y
        tryAddState(currX, Y, currIndex);

        // 3. изпразване на X
        tryAddState(0, currY, currIndex);

        // 4. изпразване на Y
        tryAddState(currX, 0, currIndex);

        // 5. преливане от X в Y
        // изчисляваме колко единици максимум може да поеме Y или колко има в X (което е по-малкото)
        int pourToY;
        if (currX < (Y - currY)) {
            pourToY = currX;
        }
        else {
            pourToY = Y - currY;
        }
        tryAddState(currX - pourToY, currY + pourToY, currIndex);

        // 6. преливане от Y в X
        // изчисляваме колко единици максимум може да поеме X или колко има в Y (което е по-малкото)
        int pourToX;
        if (currY < (X - currX)) {
            pourToX = currY;
        }
        else {
            pourToX = X - currX;
        }
        tryAddState(currX + pourToX, currY - pourToX, currIndex);
    }

    // извеждане на резултата
    if (found == true) {
        cout << "Намерено е решение! Последователност на състоянията (x, y):" << endl;
        printPath(goalIndex);
    }
    else {
        cout << "Не съществува решение за зададените параметри!" << endl;
    }
}

int main() {
    system("chcp 1251");

    cout << "==== Решение на задачата за „Водните чаши“ чрез BFS ====" << endl;
    cout << "Вместимост на чаша X: " << X << endl;
    cout << "Вместимост на чаша Y: " << Y << endl;
    cout << "Цел: " << Z << endl;
    cout << "-----------------------------------------------------------" << endl;

    solveBFS();

    system("pause");
}