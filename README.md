# strings

programma c# per lo studio delle stringhe


Questo esercizio è molto importante perchè serve per consolidare 
- l'uso del costrutto if, else

- l'uso dei vettori
- l'uso dei cicli (for, do, while)
- l'uso della mascheratura dei bit con operatori logici and, or, xor, not su dati interi
- l'uso dei metodi (la loro definizione, il passaggio di parametri)
- la tabella ASCII
- il pensiero computazionale, gli algoritmi di ordinamento
 
Questi argomenti sono ritenuti fondamentali dal dipartimento di informatica della scuola per le materie Informatica, SIR, TPSIT della classe terza e quarta.
 
In quinta, queste competenze vengono date per scontate e diventa molto difficile seguire qualsiasi argomento se non sono state affrontate in modo profondo negli anni precedenti.

-------------------------------------


Dopo queste premesse:
Realizzare una app MAUI (per chi ha Linux va bene una versione Console) per lo studio delle stringhe ASCII 7 bit (non unicode).


Nella versione da consegnare entro venerdì 24/marzo/2023 il programma dovrà elaborare una stringa in ingresso e visualizzare:
 
- la sua versione Maiuscola (visto in lab)
 
- la sua versione Minuscola (visto in lab)
 
- se contiene solo caratteri Alfabetici (Serve IsLetter, la stiamo facendo ora...)
 
- di quante lettere è formata (la stringa "abc3 ?2DEF " contiene 6 lettere)
 
- se contiene solo caratteri alfanumerici 
(la stringa "abc123DEF " contiene solo caratteri alfanumerici)
(la stringa "abc 123 DEF " NON contiene solo caratteri alfanumerici)
 
- La sua versione rovesciata (entra abcd, esce cdba)

  
Nella versione successiva da consegnare entro --/aprile/2023 il programma dovrà elaborare anche altre versioni tra cui- di quante parole è formata

- la versione Capitalized (la prima lettera di ogni parola maiuscola) 
(fare prima un toLower di tutto e poi capitalizzare la prima lettera di ogni parola)
  
- Se è palindroma 
( valgono solo frasi alfabetiche! se nella frase ci sono segni di punteggiatura o numeri non è palindromo)
( anna oppure Anna, sono entrambe palindrome)
( "amo roma" diventa "amoroma" che è palindroma )
( "i topi non avevano nipoti" diventa "itopinonavevanonipoti" che è palindroma)
( "ciao.oaic" non è palindroma)
 
altre che prevedono l'uso di operatori and, or, xor ...
