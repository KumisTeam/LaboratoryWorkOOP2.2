#pragma once
#include <vector>
#include "Point.h"
using namespace std;
class Figure
{
public:
	Figure();
	~Figure();

protected: vector<Point> allPoints;
	//public readonly List<Point> allPoints;

public: Figure(Point A, Point B, Point C);

public: Figure(Point A, Point B, Point C, Point D);
	

public: Figure(Point A, Point B, Point C, Point D, Point E);
	

protected: double Length(Point A, Point B);
	//	return Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2));
};

