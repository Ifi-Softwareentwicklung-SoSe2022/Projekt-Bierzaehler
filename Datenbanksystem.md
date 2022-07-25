Datenbanksystem
===============


Bei der Planung für die Erstellung des ER-Diagramm haben wir die Attribute und Entitäten festgestellt, aus der das Datenbanksystem bestehen wird. Dabei wurden vier Entitäten verwendet : Person, Chipkarte, Getränk und Buchung. Bei der Darstellung der Entitäten wurde das folgende Relations-Datenbankschema beschlossen: 

| **Person:**                    | **Chipkarte:**                           | **Drink:**                  | **Buchung:**                                   |
|--------------------------------|------------------------------------------|-----------------------------|------------------------------------------------|
| person_id (PK),  vorname,  nachname | chip_id (PK)    ,  person_id,    erstell_datum| Drink_id (PK),   bez,      preis| buchung_id (PK),      chip_id,    person_id   datum  |

Dabei wurde schnell bemerkt, dass man eigentlich die Entitäten Chipkarte und Person zusammenfassen kann, da Person und Chipkarte die gleiche Bedeutung in diesem Zusammenhang haben. Die Tabelle ‚Buchung‘ ist dabei entstanden, da unser Projekt um das Zählen von getrunkenem Bier geht. Diesen Zusammenhang kann man als Buchung erfassen. 

Leider ist die Bearbeitung mit Datum im Datenbanksystem komplex, da die Formatierung anderes ist, als das was man in c# hat.  Was wir machen konnten ist das Datum manuell eintragen z.B date(2022-23-07) und es wiederrum in der Konsole ausgeben lassen. Das bedeutet, dass der Benutzer es später jedes Mal selber eintragen muss, was sehr viel Aufwand und Ungenauigkeit für das Program liefern wird. Deshalb haben wir das Datum erstmal weggelassen.

Unterstrich oder Pk ist die Abkürzung für PRIMARY KEY . Bei der handelt es sich um die eindeutige Identifizierung eines Tabelle. Bei der Tabelle "Buchung" sind  „buchung_id“ und „chip_id“ als FORGEIN KEY (FK) identifiziert, damit kann man auf die andere zwei Tabellen zugreifen. Damit ist die Relationen zwischen die Tabellen abgeschlossen und die Tabelle "Buchung" ist unser Schlüssel, um die getrunkenen Biermengen zu zählen und zu kontrollieren.

Damit sieht unser Endresultat des Relationsmodell folgend aus:

### Chipkarte:                                                             
| <u>chip_id(INT) (PK)   | vorname VARCHAR(20) | nachname VARCHAR(20) |      
|------------------|---------------------|----------------------|  

### Drink:
| <u>drink_id (INT) (PK)  | bez VARCHAR(20) | preis FLOAT |
|-------------------|-----------------|-------------|

### Buchung:
| <u>buchung_id (INT) (PK)  | chip_id (FK) | drink_id (FK) |
|---------------------|------------|-------------|

  
![Hier](https://github.com/Ifi-Softwareentwicklung-SoSe2022/Projekt-Bierzaehler/blob/Mindmaps-Version-2/CHipkarte.jpg) 
Hiermit haben wir unsere ersten Gedanken zusammengefasst.
  
  
  
Verbindung zwischen Datenbanksystem und  C# herstellen:
=======================================================



Um die Verbindung mit der  Datenbankbank herzustellen, muss man SQL auf dem Betriebsystem installieren und einen Servermanager dazu. Welcher die Datenbank aufruft, um die Datenbank bearbeiten zu können. XAMPP mit Abstand hat sich gezeigt, dass das unser beste Variante ist, um unseren Zweck zu erfüllen. XAMPP stellt eine Verbindung zu dem Localhost, sodass auf dem Browser das Datenbanksystem angezeigt und bearbeitet werden kann.

Nun bleibt nur noch die Verbindung zwischen c# und dem Server herzustellen- Damit benötigt man die folgenden Informationen: Data Source, Port, Username, Password und den Name der Datenbank. Sobald man die Informationen erhalten hat, kann man durch die Bibliothek bzw. die Erweiterung "MySqlConnector" die Parameter einfügen. Somit ist der Cennectorstring implementiert
