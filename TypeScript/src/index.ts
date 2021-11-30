interface Person {
    firstName: String;
    lastName: String;
    age: Number;
    pets: String[];
}

const person = {
    firstName: "John",
    lastName: "Doe",
    age: 25,
    pets: ["dog"]
};

class IAmHuman implements Person {
    public firstName: String;
    public lastName: String;
    public age: Number;
    public pets: String[];

    constructor() {
        this.firstName = "";
        this.lastName = "";
        this.age = 0;
        this.pets = [];
    }
}

const human = new IAmHuman();

function greeting(person: Person): String {
    const result = `${person.firstName} ${person.lastName}`;
    console.log(person.pets);
    return result;
}

const myString = greeting(human);

console.log("Welcome");
console.log(myString);
