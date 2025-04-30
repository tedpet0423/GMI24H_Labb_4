

Länk till videon: https://youtu.be/TtwRbLdrDsg

Frågor; 
Tidskomplexitet för att lägga till i början av länkad lista: O(1)
Tidskomplexitet för att lägga till i mitten av länkad lista: O(n) {n/2 för att vara exakt men ingen big O notation finns för detta.}
Tidskomplexitet för att lägga till i slutet av länkad lista: O(n) 
Eftersom kan växa dynamiskt så kan vi i bästa fall få O(1) och i sämsta fall O(n) 
när vi lägger till sist i listan. Då vi måste stega igenom alla noder för att hitta till slutet

Tidskomplexitet för att lägga till i början av array: O(n)
Tidskomplexitet för att lägga till i mitten av array: O(n) 
Tidskomplexitet för att lägga till i slutet av array: O(n) 

Eftersom vi testar redan fylld array så måste vi alltid att flytta över elementen till en ny array. Därav tidskomplexiteten O(n)
Hade vi däremot använt en array som hade haft utrymme att lägga till fler element så hade tidskomplexiteten O(1) gått att uppnå
genom att lägga till efter sista elementet i arrayen.

Exempelutskrift:

Lägger till 100 värden i början av Länkad lista: 42,2 µs
Lägger till 100 värden i mitten av Länkad lista: 160,8 µs
Lägger till 100 värden i slutet av Länkad lista: 329,2 µs
Lägger till 100 värden i början av Array: 77 µs
Lägger till 100 värden i mitten av Array: 85,6 µs
Lägger till 100 värden i slutet av Array: 80 µs


Vid testet skapades en länkad lista upp med 100 element av typen int, elementet lades sedan till ett och ett i början, mitten
och i slutet. 
 