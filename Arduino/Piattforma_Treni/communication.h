
char c;
bool letturavelocita = false;
String stringa = "";
String downloadserial = "";
int velocita = 1000;

void read_serial()
{
  if (Serial.available())
  {
    String line = Serial.readStringUntil('\n');//read the line while dont recive \n
    String * datarecived = splitstring(line);
    //set position to reach

    step_position_to_reach = datarecived[0].toInt();
    speed_recived = datarecived[1].toInt();
    dir_selected = datarecived[2].toInt();

  }


}
