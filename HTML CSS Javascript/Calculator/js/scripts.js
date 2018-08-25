var result = 0;
var operand = 0;
var operator="none";
var decimal="";

function pressbtnAC() {
    operand = 0;
    result = 0;
    operator = "none";
    decimal="";
    document.getElementById("screen").value = operand;
}

function pressbtnDec() {
    decimal = operand.toString() + ".";
    document.getElementById("screen").value = decimal;
}

function pressbtn(num) {
        decimal=decimal+num;
        operand = parseFloat(decimal);
    console.log("num: ",num);
    console.log("decimal: ",decimal);
    console.log("operand: ",operand);
    console.log("result: ",result);
    document.getElementById("screen").value = decimal;
}

function pressBtnDivide() {
    Evaluate();
    operator = "divide";
}

function pressBtnSubtract() {
    Evaluate();
    operator = "subtract";
}

function pressBtnPlus() {
    Evaluate();
    operator = "plus";
}

function pressBtnMultiply() {
    Evaluate();
    operator = "multiply";
}

function pressbtnEqual() {
    Evaluate();
}

function Evaluate() {
    switch (operator) {
        case "plus":
            {
                result = result+operand;
                operand = 0;
                decimal="";
                document.getElementById("screen").value = result;
                break;
            }
        case "divide":
            {
                result = result/operand;
                operand = 0;
                decimal=0;
                document.getElementById("screen").value = result;
                break;
            }
        case "multiply":
            {
                result = result*operand;
                operand = 0;
                decimal="";
                document.getElementById("screen").value = result;
                break;
            }
        case "subtract":
            {
                result = result - operand;
                operand = 0;
                decimal="";
                document.getElementById("screen").value = result;
                break;
            }
        case "none":
            {
                result = operand;
                decimal="";
                document.getElementById("screen").value = 0;
                operand = 0;
                break;
            }
            default:{
                document.getElementById("screen").value = result;
            }
    }
}