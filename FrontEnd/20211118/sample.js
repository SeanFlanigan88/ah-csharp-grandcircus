let secondary = 0;
let operation = undefined;
let main = 0;

function setup() {
    secondary = 0
    operation = undefined
    main = 0

    document.getElementById("secondary").innerText = ""
    document.getElementById("operation").innerText = ""
    document.getElementById("main").innerText = ""
}

function setOperation(op) {
    operation = op
    document.getElementById("operation").innerText = operation
}

function input(num) {
    console.log(num);
    if (document.getElementById("main").innerText == "")
    {
        main = num
        document.getElementById("main").innerText = num
    }
    else
    {
        secondary = Number(document.getElementById("main").innerText)
        document.getElementById("secondary").innerText = secondary
        main = num
        document.getElementById("main").innerText = num
    }
}

function calculate() {
    let output = 0
    switch (operation)
    {
        case "+":
            output = Number(secondary) + Number(main);
            break;
        case "-":
            output = Number(secondary) - Number(main);
            break;
        case "*":
            output = Number(secondary) * Number(main);
            break;
        case "/":
            output = Number(secondary) / Number(main);
            break;
    }

    document.getElementById("operation").innerText = ""
    document.getElementById("secondary").innerText = ""
    document.getElementById("main").innerText = output
}

setup()