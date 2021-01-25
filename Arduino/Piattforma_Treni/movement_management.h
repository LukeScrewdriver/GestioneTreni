void movimento(int direction_rotation)//incrementale
{
  static int fase = 0;
  static unsigned long tmpmem = millis();

  switch (fase)
  {
    case (0):
      if (direction_rotation == 0)
      {
        digitalWrite(PIN_MOTOR_DIR, HIGH);//pin rotazione
        digitalWrite(PIN_MOTOR_STEP, HIGH);//pin step
        step_position++;
        fase++;
      }
      else if (direction_rotation == 1)
      {
        digitalWrite(PIN_MOTOR_DIR, LOW);//
        digitalWrite(PIN_MOTOR_STEP, HIGH);//pin step
        step_position--;
        fase++;
      }
      break;

    case (1):
      if (non_blocking_delay(&tmpmem, 1)) //wait that motor reach the position
      {
        digitalWrite(PIN_MOTOR_STEP, LOW);
        tmpmem = millis();
        fase = 0;
      }
      break;
  }
}


void azzeramento()
{
  static unsigned long tmpmem = millis();
  //Serial.println("azzeramento");
  movimento(true);
  do
  {

    if (non_blocking_delay(&tmpmem, 200)) //wait that motor reach the position
    {
      movimento(true);
      tmpmem = millis();
    }
  }
  while (digitalRead(PIN_ENDSTOP) == HIGH);//position reached
  step_position = 0;//set zero


}

long positioncheck(long curr_position) {
  if (curr_position > STEP_FULL_ROTATION) {
    curr_position = 0;
  }

  if (curr_position < 0) {
    curr_position = STEP_FULL_ROTATION;
  }
}
