### Command Line Arduino
Install arduino-cli:
```Shell
$ curl -fsSL https://raw.githubusercontent.com/arduino/arduino-cli/master/install.sh | sh
``` 

Set-up indexes:
' $ arduino-cli core update-index

Create config file:
$ arduino-cli config init

Edit config file:
$ cd .arduino
$ nano arduino-cli.yaml

Search definition file:
$ arduino-cli core search uno

Install definition file:
$ arduino-cli install arduino:avr

Install tool chain:
$ arduino-cli core install arduino:avr

create new sketch:
$ arduino-cli sketch new test01

Edit sketch in nano with line numbers and multiple files:
$ nano --linenumber -F test01.ino

Compile Arduino sketch:
$ arduino-cli compile --fqbn arduino:avr:uno test01

List boards connected to USB:
$ arduino-cli board list
Port         Type              Board Name  FQBN            Core
/dev/ttyACM0 Serial Port (USB) Arduino Uno arduino:avr:uno arduino:avr
/dev/ttyAMA0 Serial Port       Unknown

Upload to the board:
$ arduino-cli upload --port /dev/ttyACM0 --fqbn arduino:avr:uno sketchbook/test01
