# Jumper - The Unit
## Inleiding
Er wordt een *agent* getraind om over obstakels te springen.
### Scenario 1
Voor de 1<sup>ste</sup> scenario hebben we gekozen voor de **1<sup>ste</sup>** functionaliteit bij de opdrachtomschrijving, namelijk dat de *agent* geconfronteerd wordt met een rij van continu bewegende obstakels en over deze moet springen.
### Scenario 2
Als <ins>extra</ins> scenario hebben we gekozen voor de **4<sup>de</sup>** functionaliteit bij de opdrachtomschrijving, namelijk dat de *agent* op het midden van een platform staat en obstakels moet ontwijken, die vanuit twee richtingen komen, door er over te springen.
## Observaties
De *agent* kan de omgeving observeren met *rays*, of stralen. Dit wordt gedaan door aan de *agent* de *Ray Perception Sensor 3D*-component te geven. 
Deze component geeft de *agent* ogen, in de vorm van stralen, en geeft de mogelijkheid om zijn 3D-omgeving te verkennen door middel van *raycasting*.
![](Assets/Images/MicrosoftTeams-image (1).png)
## Acties
Om obstakels te kunnen ontwijken, moet de *agent* kunnen springen. Hierdoor heeft de *agent* maar één mogelijke actie.
* 1 verticale actie: springen.

Om de *agent* te kunnen laten springen, gebruiken we de *Rigidbody*-component. Met deze component, kan een object reageren op fysica. Deze component is ook best gebruikt met een *Collider*-component, in dit geval een *Box Collider*, om botsingen te detecteren.  
Wij gebruiken de *Rigidbody* om aan de *agent* een verticale kracht te geven die vervolgens met zwaartekracht terug naar beneden valt.
## Beloning
Tijdens het leerproces, moet de *agent* weten of die goed aan het presteren is of niet. Dit wordt verwezenlijkt door een beloningssysteem.  
* Wij belonen de *agent* met **+1** als die over een obstakel kan springen.
* Als de *agent* niet over een obstakel kan springen en erop landt, krijgt die een straf van **-1**.
* Ook krijgt de *agent* een klein strafje van **-0.01** als die voor niets springt.
## Spelverloop
Text
## Configuratie
SANDER?
## Resultaten
SANDER?
## Conclusie
De *agent* die we trainde om over een blokje dat constant vanuit dezelfde richting met verschillende snelheden aankomt te springen, is gelukt in ongeveer 1 miljoen stappen. Dit was de originele opdracht, als extra hebben wij dit vanuit beide richtingen laten komen en probeerden wij de agent dit aan te leren om over een blokje dat op 1/2 locaties constant spawned met verschillende snelheid te sprigen, was dit na ~5.486.000 stappen nog niet gelukt om het consistent te doen.

De neurale netwerken zijn terug te vinden in *Assets* &rarr; *NeuralNetworks*.
* Het *Jumper1Direction*-brein is voor scenario 1.
* Het *Jumper2Directions*-brein is voor scenario 2.

Hiervoor werd respectievelijk gebruik gemaakt van de *Jumper4* en *JumperV5* folders binnen *Learning* &rarr; *results*.  
