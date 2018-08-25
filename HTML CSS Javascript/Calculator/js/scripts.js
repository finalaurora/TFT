var result = 0;
var operand = 0;
var operator;

function pressbtnAC() {
    operand = 0;
    result = 0;
    operator = "none";
    document.getElementById("screen").value = operand;
}

function pressbtn(num) {
    var val = operand;
    operand = operand * 10 + num;
    document.getElementById("screen").value = operand;
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
function pressbtnEqual(){
    Evaluate();
}
function Evaluate() {
    switch (operator) {
        case "plus":
            {
                result += operand;
                operand=0;
                document.getElementById("screen").value = result;
                break;
            }
        case "divide":
            {
                result /= operand;
                operand=0;
                document.getElementById("screen").value = result;
                break;
            }
        case "multiply":
            {
                result *= operand;
                operand=0;
                document.getElementById("screen").value = result;
                break;
            }
        case "subtract":
            {
                result = result - operand;
                operand=0;
                document.getElementById("screen").value = result;
                break;
            }
        default:
            {
                result=operand;
                document.getElementById("screen").value = 0;
                operator = "none";
                operand = 0;
                break;
            }
    }

}