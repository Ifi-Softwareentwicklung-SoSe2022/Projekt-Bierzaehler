Angedacht war in der Planung den Raspberry PI (damals noch nicht bekannt welches Modell) mit Windows IoT 10 zu bespielen. Leider unterstützt jedoch WIN IoT 10 nicht die ARM Architektur. Somit wurde Debian 11 die Ausweichvariante, was jedoch etliche Probleme mit sich brachte, da Debian 11 Linux basiert ist. <br>
<br>
Probleme, die sich durch Änderung des OS auftaten, waren: <br>
<br>
- kein direkter c# (dotNET6) support <br>
- kein Framework support <br>
- kein support für Xampp <br>

Lösung der oben genannten Probleme: <br>

- dotNET6 konnte durch eine Windows SDK Erweiterung behoben werden <br>
- für Framework wurde das Mono Project 6.12. installiert <br>
- statt Xampp wurde eine LAMP-Lösung installiert <br>
<br>
Die jeweiligen Komponenten wurden getestet: <br>
<br>
- Framework funktionierte mit Mono und der Test-UI einwandfrei <br>
- Das LAMP Packet wurde mit einem DOTNET6 Probeprogramm zum Verbindungsaufbau und zur Abfrage einzelner Daten aus der Datenbank getestet. <br>
  Funktion: Einwandfrei
  
