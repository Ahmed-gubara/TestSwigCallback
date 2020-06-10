%module (directors="1") MathCpp


%{

#include "Calc.h"

%}


%include <std_string.i> 
%feature("director") MyCalc;
%include "Calc.h"
//%include "input_output/FGGroundCallback.h"
