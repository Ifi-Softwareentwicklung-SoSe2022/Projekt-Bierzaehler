## Vollständiges Programm
Nach dem in die Button des UI Funktionen implementiert wurden, welche INSERT und SELECT funktionen ausführen sollten, wurde das Gesamtprogramm 
auf den vorbereiteten Rapberry PI geladen.
Das UI öffnete sich problemlos, sobald jedoch eine ButtonClick Funktion ausgeführt werden sollte schloss sich
das UI. <br>
<br>
Durch Prüfen der Datenbank wurde leider kein Eintrag geändert. <br>
Vermutung: Das Monoproject kann zwar Framework darstellen, jedoch nicht ein C# Programm ausführen. <br>
<br>
Nach dem wir versuchten das Gesamte Projekt auf DOTNET6 zu übertragen, scheiterten wir am User Interface. 
dotnet run gab leider keine Rückmeldung in die Konsole und das Userinterface, wie sich später herrausstellte, wurde wieder mit Framework compiliert. Leider haben wir keine Lösung gefunden, um Mono mit Dotnet zu verbinden. <br>
<br>
Der nächste Versuch, mit der Erweiterung von Avalonia in Visual Studio eine Applikation zu erschaffen, welche sowohl UI und den C# code wiedergeben soll, schlug fehl. <br>
<br>
Jedoch gelang uns der Versuch mit einem reinen Konsolen-Code den Server zu kontaktieren, über Konsole Daten einzufügen und abzurufen. 
