unsigned int sure,mesafe;
int echo = 8;
int trig = 7;
int led = 10;

void setup() {
  pinMode(trig,OUTPUT);
  pinMode(echo,INPUT);
  pinMode(led,OUTPUT);
  Serial.begin(9600);
  

}

void loop() {
  //Serial.println("1");
  //delay(1000);
  //Serial.println("0");
  //delay(1000);
  digitalWrite(trig,HIGH);
  delayMicroseconds(20);
  digitalWrite(trig,LOW);
  sure=pulseIn(echo,HIGH);
  mesafe=(sure/2)/29.1;
  if (mesafe < 50){
    Serial.println("1");
    digitalWrite(led,HIGH);
    delay(2000);
    digitalWrite(led,LOW);
    }
}
