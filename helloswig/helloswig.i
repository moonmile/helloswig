/* File : helloswig.i */
%module helloswig

%{
#include "helloswig.h"
%}

/* Let's just grab the original header file here */
%include "helloswig.h"
