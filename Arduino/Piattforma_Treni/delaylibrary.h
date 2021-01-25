
bool non_blocking_delay(unsigned long *tmp, long timeElapse) {
  unsigned long current_Millis = millis();
  bool result = false;

  if ((current_Millis - *tmp) >= timeElapse)
  {
    result = true;
  }
  
  return result;
}
