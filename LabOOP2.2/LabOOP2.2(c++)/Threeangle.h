#pragma once
#include "Figure.h"
class Threeangle :
	public Figure
{
public:
	Threeangle();
	~Threeangle();

	Threeangle(Point _A, Point _B, Point _C)
		:Figure(_A, _B, _C) {};

	double Square();
	double Perim();
	void Show();

};

