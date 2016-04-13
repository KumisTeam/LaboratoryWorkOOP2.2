#include "stdafx.h"
#include "Threeangle.h"
#include <math.h>


Threeangle::Threeangle()
{
}


Threeangle::~Threeangle()
{
}

double Threeangle::Perim()
{
	double side1 = Length(allPoints[0], allPoints[1]);
	double side2 = Length(allPoints[1], allPoints[2]);
	double side3 = Length(allPoints[2], allPoints[0]);

	return side1 + side2 + side3;
}

double Threeangle::Square()
{
	double PartPerim = Perim() / 2;

		double side1 = Length(allPoints[0], allPoints[1]);
		double side2 = Length(allPoints[1], allPoints[2]);
		double side3 = Length(allPoints[2], allPoints[0]);

		return sqrt(PartPerim
			* (PartPerim - side1)
			* (PartPerim - side2)
			* (PartPerim - side3));
	
}
