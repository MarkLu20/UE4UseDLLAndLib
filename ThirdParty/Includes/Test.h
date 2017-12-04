#ifndef MYLIB_H
#define MYLIB_H
class myclass
{
public:
	myclass()
	{
		x = 0;
		y = 0;
	}
	~myclass() {}
	int show(int x, int y);
private:
	int x;
	int y;
};
#endif
