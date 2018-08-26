var result = 0;
var operand = 0;
var operator="none";
var decimal="";
var expression="";
function pressbtnAC() {
    operand = 0;
    result = 0;
    operator = "none";
    decimal="";
    expression="";
    document.getElementById("expression").innerHTML=expression;
    document.getElementById("result").innerHTML = operand;
}

function pressbtnDec() {
    decimal = operand.toString() + ".";
    document.getElementById("result").innerHTML = decimal;
}

function pressbtn(num) {
        decimal=decimal+num;
        operand = parseFloat(decimal);
    console.log("num: ",num);
    console.log("decimal: ",decimal);
    console.log("operand: ",operand);
    console.log("result: ",result);
    document.getElementById("result").innerHTML = decimal;
}

function pressBtnDivide() {
    Evaluate();
    operator = "divide";
    expression=expression+operand+"/";
    document.getElementById("expression").innerHTML=expression;
    operand=0;
}

function pressBtnSubtract() {
    Evaluate();
    operator = "subtract";
    expression=expression+operand+"-";
    document.getElementById("expression").innerHTML=expression;
    operand=0;
}

function pressBtnPlus() {
    Evaluate();
    operator = "plus";
    expression=expression+operand+"+";
    document.getElementById("expression").innerHTML=expression;
    operand=0;
}

function pressBtnMultiply() {
    Evaluate();
    operator = "multiply";
    expression=expression+operand+"x";
    document.getElementById("expression").innerHTML=expression;
    operand=0;
}

function pressbtnEqual() {
    expression=expression+operand;
    Evaluate();
    document.getElementById("expression").innerHTML=expression;
    operand=0;
    expression=result.toString();
}

function Evaluate() {
    switch (operator) {
        case "plus":
            {
                result = result+operand;
                
                decimal="";
                document.getElementById("result").innerHTML = result;
                break;
            }
        case "divide":
            {
                result = result/operand;
                
                decimal=0;
                document.getElementById("result").innerHTML = result;
                break;
            }
        case "multiply":
            {
                result = result*operand;
                
                decimal="";
                document.getElementById("result").innerHTML = result;
                break;
            }
        case "subtract":
            {
                result = result - operand;
                
                decimal="";
                document.getElementById("result").innerHTML = result;
                break;
            }
        case "none":
            {
                result = operand;
                decimal="";
                document.getElementById("result").innerHTML = 0;
                break;
            }
            default:{
                document.getElementById("result").innerHTML = result;
            }
    }
}