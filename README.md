# Projekt-Bierzaehler
Projekt Softwareentwicklung SOSE 2022 Juri Nagel (66968) Riad Rustum (64884)

Der Bierzähler soll ein Gadget bestehend aus RFID-Chips, RFID-Reader, Raspberry PI und einem Display sein.<br>
Hierfür soll eine Datenbank initialisiert werden, auf der die Daten die der RFID-Reader liefert gespeichert werden. Die Datenbank soll Name, Chip-ID, 
Biersorte, Anzahl der getrunkenen Biere pro Person und die Gesamtrechnung speichern. Die Datenbank soll auf dem Raspberry-PI als 
local-host gespeichert werden. Sobald einer der RFID-Chips eine Interaktion mit dem RFID-Reader durchführt, soll auf dem Display, per GUI der Name, der der Person zugewiesen ist, anzeigen.
Der User kann nun auf der GUI entscheiden zwischen Freiberger, Oettinger, seiner Abrechnung, seiner Anzahl getrunkener Biere, und der Gesamtabrechnung.
Sobald der User entschieden hat, wird entweder ein Wert der Datenbank geändert, oder abgerufen. <br> 

#### Schritt 1:<br> 
Erstellen einer Datenbank die tabellarisch Werte aufnimmt und eine Verbindung über C# herstellen. [Link](https://github.com/Ifi-Softwareentwicklung-SoSe2022/Projekt-Bierzaehler/blob/Dokumentation/Datenbanksystem.md) <br>
#### Schritt 2:<br> 
Erstellen einer GUI die benutzerfreundlich ist und eine Verbindung mit der Datenbank über C# erstellt. [Link1](https://github.com/Ifi-Softwareentwicklung-SoSe2022/Projekt-Bierzaehler/blob/Dokumentation/Versuch%20des%20vollständigen%20Programms.md),[Link2](https://github.com/Ifi-Softwareentwicklung-SoSe2022/Projekt-Bierzaehler/blob/Dokumentation/Planung%20des%20UI)
<br> 
#### Schritt 3: <br> 
RFID-Reader mit Raspberry-PI verbinden. [Link](https://github.com/Ifi-Softwareentwicklung-SoSe2022/Projekt-Bierzaehler/blob/Dokumentation/Raspberry%20PI%204%20vorbereiten.md) <br>
#### Schritt 4: <br> 
Datenbank, C#-Programm auf Raspberry-PI übertragen und Display anschliessen. [Link](https://github.com/Ifi-Softwareentwicklung-SoSe2022/Projekt-Bierzaehler/blob/Dokumentation/Raspberry%20PI%204%20vorbereiten.md) <br>





