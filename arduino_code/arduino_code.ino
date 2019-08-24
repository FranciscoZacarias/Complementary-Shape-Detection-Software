#include<Servo.h>

//pins
int relay = 8;
int servoy = 11;
int servox = 10;
int laser = 13;
//endpins
int relay_state = HIGH;

Servo servo_x;
Servo servo_y;

String serial_data;

void setup() 
{
  servo_x.attach(servox);
  servo_y.attach(servoy);
  
  pinMode(laser, OUTPUT);
  digitalWrite(laser, HIGH);
  pinMode(relay, OUTPUT);
  digitalWrite(relay, relay_state);

  Serial.begin(9600);
  Serial.setTimeout(10);
}

void loop() 
{
}

void serialEvent() 
{
  serial_data = Serial.readString();  
  
  int x = parse_x(serial_data);
  int y = parse_y(serial_data);
  
  servo_x.write(x);
  servo_y.write(y);
  
  Serial.println("X" + String(servo_x.read()) + "Y" + String(servo_y.read()));
}

int parse_x(String data)
{
  data.remove(data.indexOf("Y"));
  data.remove(data.indexOf("X"), 1);
  return data.toInt();
}

int parse_y(String data)
{
  data.remove(0,data.indexOf("Y") + 1);
  return data.toInt();
}
