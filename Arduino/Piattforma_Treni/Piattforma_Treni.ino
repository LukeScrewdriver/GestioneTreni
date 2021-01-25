#include "define.h"
#include "delaylibrary.h"
#include "splitlibrary.h"
#include "communication.h"
#include "movement_management.h"


void setup() {

  Serial.begin(BAUDRATE);
  pinMode(PIN_MOTOR_STEP, OUTPUT);
  pinMode(PIN_MOTOR_DIR, OUTPUT);
  pinMode(PIN_ENDSTOP, INPUT_PULLUP);

  azzeramento();
}





void loop()
{
  read_serial();

  if (step_position == step_position_to_reach)//position not reached
  {
    speed_recived = 0;
    dir_selected = 2;
  }
  
  movimento(dir_selected);

  positioncheck(step_position);


}
