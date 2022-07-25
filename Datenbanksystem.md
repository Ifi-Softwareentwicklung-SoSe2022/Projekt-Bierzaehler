Datenbanksystem
===============


Bei der Planung für die Erstellung des ER-Diagramm haben wir die Attribute und Entitäten festgestellt, aus der das Datenbanksystem bestehen wird. Dabei wurden vier Entitäten verwendet : Person, Chipkarte, Getränk und Buchung. Bei der Darstellung der Entitäten wurde das folgende Relations-Datenbankschema beschlossen: 

| **Person:**                    | **Chipkarte:**                           | **Drink:**                  | **Buchung:**                                   |
|--------------------------------|------------------------------------------|-----------------------------|------------------------------------------------|
| person_id,  vorname,  nachname | chip_id    ,  person_id,    erstell_datum| Drink_id,   bez,      preis| buchung_id,      chip_id,    person_id   datum  |

Dabei wurde schnell bemerkt, dass man eigentlich die Entitäten Chipkarte und Person zusammenfassen kann, da Person und Chipkarte die gleiche Bedeutung in diesem Zusammenhang haben. Die Tabelle ‚Buchung‘ ist dabei entstanden, da unser Projekt um das Zählen von getrunkenem Bier geht. Diesen Zusammenhang kann man als Buchung erfassen. 

Leider ist die Bearbeitung mit Datum im Datenbanksystem komplex, da die Formatierung anderes ist, als das was man in c# hat.  Was wir machen konnten ist das Datum manuell eintragen z.B date(2022-23-07) und es wiederrum in der Konsole ausgeben lassen. Das bedeutet, dass der Benutzer es später jedes Mal selber eintragen muss, was sehr viel Aufwand und Ungenauigkeit für das Program liefern wird. Deshalb haben wir das Datum erstmal weggelassen.

Die Unterstriche deuten den PRIMARY KEY zu. Bei der Buchung sind  „buchung_id“ und „chip_id“ als FORGEIN KEY implementiert, damit kann man auf IDE auf andere Tabellen zugreifen.
Damit ist Buchungsentität unser Schlüssel, um die getrunkenen Biermengen zu zählen und zu kontrollieren.

Damit sieht unser Endresultat des Relationsmodell folgend aus:

### Chipkarte:                                                             
| <u>chip_id(INT)  | vorname VARCHAR(20) | nachname VARCHAR(20) |      
|------------------|---------------------|----------------------|  

### Drink:
| <u>drink_id (INT)   | bez VARCHAR(20) | preis FLOAT |
|-------------------|-----------------|-------------|

### Buchung:
| <u>buchung_id (INT)  | chip_id FK | drink_id FK |
|---------------------|------------|-------------|

  
![Hier](https://github.com/Ifi-Softwareentwicklung-SoSe2022/Projekt-Bierzaehler/blob/Mindmaps-Version-2/CHipkarte.jpg) 
                                        Hiermit haben wir unsere erste Gedanken zusammengefasst.
