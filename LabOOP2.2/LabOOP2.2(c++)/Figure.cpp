#include "stdafx.h"
#include "Figure.h"

#include <math.h>

Figure::Figure()
{
}


Figure::~Figure()
{
}

Figure::Figure(Point A, Point B, Point C)
{
	allPoints.push_back(A);
	allPoints.push_back(B);
	allPoints.push_back(C);
}

Figure::Figure(Point A, Point B, Point C, Point D)
{
	allPoints.push_back(A);
	allPoints.push_back(B);
	allPoints.push_back(C);
	allPoints.push_back(D);
}

Figure::Figure(Point A, Point B, Point C, Point D, Point E)
{
	allPoints.push_back(A);
	allPoints.push_back(B);
	allPoints.push_back(C);
	allPoints.push_back(D);
}

double Figure::Length(Point A, Point B)
{
	return sqrt(pow((A.x - B.x), 2) + pow((A.y - B.y), 2));
}
