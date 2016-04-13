// LabOOP2.2(c++).cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Point.h"
#include "Threeangle.h"

#include <iostream>

int main()
{
	Point A(2, 4);
	Point B(5, 2);
	Point C(3, 5);

	Threeangle ABC(A, B, C);

	cout << ABC.Perim() << endl;
	cout << ABC.Square() << endl;

    return 0;
}

