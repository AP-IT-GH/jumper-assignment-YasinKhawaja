# Jumper - The Unit
## Inleiding
Er wordt een *agent* getraind om over obstakels te springen.  
De *agent* staat op het midden van een platform en moet obstakels ontwijken, die vanuit twee richtingen komen, door er over te springen.
## Observaties
De *agent* kan de omgeving observeren met *rays*, of stralen. Dit wordt gedaan door aan de *agent* de *Ray Perception Sensor 3D*-component te geven. 
Deze component geeft de *agent* ogen, in de vorm van stralen, en geeft de mogelijkheid om zijn 3D-omgeving te verkennen door middel van *raycasting*.
## Acties
Om obstakels te kunnen ontwijken, moet de *agent* kunnen springen. Hierdoor heeft de *agent* maar één mogelijke actie.
* 1 verticale actie: springen.

Om de *agent* te kunnen laten springen, gebruiken we de *Rigidbody*-component. Met deze component, kan een object reageren op fysica. Deze component is ook best gebruikt met een *Collider*-component, in dit geval een *Box Collider*, om botsingen te detecteren.  
Wij gebruiken de *Rigidbody* om aan de *agent* een verticale kracht te geven die vervolgens met zwaartekracht terug naar beneden valt.
## Beloning
Tijdens het leerproces, moet de *agent* weten of die goed aan het presteren is of niet. Dit wordt verwezenlijkt door een beloningssysteem.  
* Wij belonen de *agent* met **+1** als die over een obstakel kan springen.
* Als de *agent* niet over een obstakel kan springen en erop landt, krijgt die een straf van **-1**.
* Ook krijgt de *agent* een klein strafje van **-0.01** als die voor niks springt.
## Spelverloop
Text
## Configuratie
SANDER?
## Resultaten
SANDER?
## Conclusie
SANDER?
