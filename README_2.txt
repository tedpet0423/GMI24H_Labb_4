
Frågor kring stackar och kö:

a) Vilken tidskomplexitet har en stack respektive kö. Svara för metoderna/algoritmerna push(), pop() och peek() för stack samt för resp. dequeue, enqueue och peek för kö.

Stack:
    Push är O(1) eftersom vi inte behöver stega någonvart då vi lägger till det överst på stacken. 
    Pop är O(1), samma där eftersom vi inte behöver stega någonvart då vi tar bort det överst på stacken.
    Peek är densamme som de andra två, alltså O(1). Vi tittar bara på första objektet utan att ta bort eller lägga till.
    
Queue: 
    dequeue är O(1) eftersom datastrukten följer FIFO samt att vi har tillgång till början och slutet av kön. 
    enqueue är O(1), likvärdigt som förklaringen innan. 
    peek är även den 0(1).
    
Stack och Queues är linjära datatyper som är optimerade för Add/Remove-operationer.   

b) Med t.ex. en List eller Array, kan vissa operationer(som att ta bort det första elementet i en lista) bli O(n), varför?

Om vi vet vilket index elementet ligger på kan vi hämta med tidskomplexitet O(1) (direct access).
Om vi har utrymme att lägga till fler element kan vi lägga till sist i listan med tidskomplexitet O(1)då vi inte behöver traversa eller flytta element i array. 
Om vi inte vet vilket indexet elementet ligger på eller att arrayen inte har några tomma platser så behöver vi antingen traversa eller flytta element till en ny array (immutable). Detta ger tidskomplexiteten O(n)

Listan skiljer sig eftersom vi alltid kan lägga till elementen pga. att den växer dynamiskt. Därför har "lägga till" i listan tidskomplexitet O(1) och hitta element på okänt index O(n).


