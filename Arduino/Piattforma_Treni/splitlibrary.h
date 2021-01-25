/*
   This piece of code was copied from
   https://github.com/zmaker/arduino_cookbook/tree/master/311-SplitString/RGBSerial

*/


String *  splitstring(String input)
{
  String output[5];
  if (input.length() > 0) {
    //Serial.println(line);
    int m = 0;
    int n = input.indexOf(";");
    int indice = 0;
    
    while (n > 0) {
      String token = input.substring(n, m);
      //Serial.println(token);
      m = n + 1;
      n = input.indexOf(";", n + 1);

      //elaboro il token:
      output[indice] = token;
      indice++;
    }
  }

  return output;
}
