/*##### Serial comunication #####*/
#define BAUDRATE                           9600

/*##### Step full rotation #####*/
#define STEP_FULL_ROTATION                 3199

/*##### Stepper motor settings #####*/
#define PIN_MOTOR_DIR                      3
#define PIN_MOTOR_STEP                     2

/*##### Pin endstop #####*/
#define PIN_ENDSTOP                        6   //pin per azzeramento piattaforma

/*##### Variables #####*/
float degrees_position = 0;
long step_position = 0;

/*##### Data recived #####*/
long step_position_to_reach = 0; 
int speed_recived = 0;
int dir_selected = 2;
/*
   0 - clockwise
   1 - counterclockwise
   2 - none
*/
