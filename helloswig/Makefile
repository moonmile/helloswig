all: libhelloswig.so

libhelloswig.so: helloswig.o
	g++ -sharad helloswig.o helloswig_wrap.o -o libhelloswig.so
helloswig.o: helloswig.cpp
	g++ -c helloswig.cpp
helloswig_wrap.o: helloswig_wrap.cpp
	g++ -c helloswig_wrap.cpp

