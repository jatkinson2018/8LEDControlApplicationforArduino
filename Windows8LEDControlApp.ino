int redLEDPin1=2; //Declare redLEDPin1 is at pin 2 of the Arduino
int redLEDPin2=3; //Declare redLEDPin2 is at pin 3 of the Arduino
int blueLEDPin1=4;  //Declare blueLEDPin1 is at pin 4 of the Arduino
int blueLEDPin2=5;  //Declare blueLEDPin2 is at pin 5 of the Arduino
int greenLEDPin1=6; //Declare greenLEDPin1 is at pin 6 of the Arduino
int greenLEDPin2=7; //Declare greenLEDPin2 is at pin 7 of the Arduino
int yellowLEDPin1=8;  //Declare yellowLEDPin1 is at pin 8 of the Arduino
int yellowLEDPin2=9;  //Declare yellowLEDPin2 is at pin 8 of the Arduino
int delayTime=500;
char state; //Declare a variable for the state of the LED°s





void setup() {
  Serial.begin(9600); //Set up serial port

  // Set all LED pins to an output
  pinMode(redLEDPin1, OUTPUT);
  pinMode(redLEDPin2, OUTPUT);
  pinMode(blueLEDPin1, OUTPUT);
  pinMode(blueLEDPin2, OUTPUT);
  pinMode(greenLEDPin1, OUTPUT);
  pinMode(greenLEDPin2, OUTPUT);
  pinMode(yellowLEDPin1, OUTPUT);
  pinMode(yellowLEDPin2, OUTPUT);

}

void loop() {
  state=Serial.read(); //Read from serial port
  switch(state){ //Declare a switch with the state variable as the argument
    //------------------- ON CONTROL -------------------------
    case '1':
      digitalWrite(redLEDPin1,HIGH);
      break;
      case '2':
      digitalWrite(redLEDPin2,HIGH);
      break;
      case '3':
      digitalWrite(blueLEDPin1,HIGH);
      break;
      case '4':
      digitalWrite(blueLEDPin2,HIGH);
      break;
      case '5':
      digitalWrite(greenLEDPin1,HIGH);
      break;
      case '6':
      digitalWrite(greenLEDPin2,HIGH);
      break;
      case '7':
      digitalWrite(yellowLEDPin1,HIGH);
      break;
      case '8':
      digitalWrite(yellowLEDPin2,HIGH);
      break;
     //------------------- OFF CONTROL -------------------------
      case 'A':
      digitalWrite(redLEDPin1,LOW);
      break;
      case 'B':
      digitalWrite(redLEDPin2,LOW);
      break;
      case 'C':
      digitalWrite(blueLEDPin1,LOW);
      break;
      case 'D':
      digitalWrite(blueLEDPin2,LOW);
      break;
      case 'E':
      digitalWrite(greenLEDPin1,LOW);
      break;
      case 'F':
      digitalWrite(greenLEDPin2,LOW);
      break;
      case 'G':
      digitalWrite(yellowLEDPin1,LOW);
      break;
      case 'H':
      digitalWrite(yellowLEDPin2,LOW);
      break;
     //------------------- ALL ON CONTROL -------------------------
      case 'Z':
      digitalWrite(redLEDPin1,HIGH);
      digitalWrite(redLEDPin2,HIGH);
      digitalWrite(blueLEDPin1,HIGH);
      digitalWrite(blueLEDPin2,HIGH);
      digitalWrite(greenLEDPin1,HIGH);
      digitalWrite(greenLEDPin2,HIGH);
      digitalWrite(yellowLEDPin1,HIGH);
      digitalWrite(yellowLEDPin2,HIGH);
      break;
     //------------------- ALL OFF CONTROL -------------------------
      case '0':
      digitalWrite(redLEDPin1,LOW);
      digitalWrite(redLEDPin2,LOW);
      digitalWrite(blueLEDPin1,LOW);
      digitalWrite(blueLEDPin2,LOW);
      digitalWrite(greenLEDPin1,LOW);
      digitalWrite(greenLEDPin2,LOW);
      digitalWrite(yellowLEDPin1,LOW);
      digitalWrite(yellowLEDPin2,LOW);
      break;
     //------------------- ALL RED ON -------------------------
     case 'a':
      digitalWrite(redLEDPin1,HIGH);
      digitalWrite(redLEDPin2,HIGH);
      break;
      //------------------- ALL BLUE ON -------------------------
      case 'b':
      digitalWrite(blueLEDPin1,HIGH);
      digitalWrite(blueLEDPin2,HIGH);
      break;
      //------------------- ALL GREEN ON -------------------------
      case 'c':
      digitalWrite(greenLEDPin1,HIGH);
      digitalWrite(greenLEDPin2,HIGH);
      break;
     //------------------- ALL YELLOW ON -------------------------
      case 'd':
      digitalWrite(yellowLEDPin1,HIGH);
      digitalWrite(yellowLEDPin2,HIGH);
      break;
  
     //------------------- RED BLINK 1 --------------------------------
      case 'e':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
     //------------------- RED BLINK 2 --------------------------------
      case 'f':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
     //------------------- RED BLINK 3 --------------------------------
      case 'g':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 4 --------------------------------
      case 'h':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 5 --------------------------------
      case 'i':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 6 --------------------------------
      case 'j':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 7 --------------------------------
      case 'k':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
     //------------------- RED BLINK 8 --------------------------------
      case 'l':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
       //------------------- RED BLINK 9 --------------------------------
      case 'm':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 10 --------------------------------
      case 'n':
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin1,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin1,LOW);
      delay(delayTime);
      break;
      //------------------- RED(2) BLINK 1 --------------------------------
      case 'o':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
     //------------------- RED BLINK 2 --------------------------------
      case 'p':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
     //------------------- RED BLINK 3 --------------------------------
      case 'q':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 4 --------------------------------
      case 'r':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 5 --------------------------------
      case 's':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 6 --------------------------------
      case 't':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 7 --------------------------------
      case 'u':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
     //------------------- RED BLINK 8 --------------------------------
      case 'v':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
       //------------------- RED BLINK 9 --------------------------------
      case 'w':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
      //------------------- RED BLINK 10 --------------------------------
      case 'x':
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      digitalWrite(redLEDPin2,HIGH);
      delay(delayTime);
      digitalWrite(redLEDPin2,LOW);
      delay(delayTime);
      break;
}
   
     

  
  
  


}
