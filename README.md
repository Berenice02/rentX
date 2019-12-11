## RentIT è un’applicazione pensata per facilitare la visibilità di oggetti in affitto.
Non è necessaria l’autenticazione per visualizzare e contattare telefonicamente o tramite mail gli utenti che hanno pubblicato annunci, ma è invece necessaria per poter inserire un annuncio da rendere visibile sulla piattaforma.
Tramite l’applicazione, una volta registrati e autenticati, è possibile inserire nuovi annunci e gestire annunci inseriti precedentemente. Una volta che gli utenti si sono accordati sull’affitto dell’oggetto, il proprietario dovrà andare nella sezione “I miei annunci”, nella pagina degli annunci “attivi”, selezionare l’oggetto in questione  e premere su “è prenotato”. Questa azione sposta l’annuncio nella sezione dei “prenotati”. Una volta terminato l’affitto, per renderlo nuovamente attivo e quindi visibile, bisognerà selezionare l’oggetto in questione nella sezione “prenotati” e premere sul pulsante “disponibile”.
La gestione dei termini di affitto, pagamento e logistica sono lasciati agli utenti che possono accordarsi tramite i recapiti disponibili e ben visibili in ogni annuncio. 
Ogni utente ha la possibilità tramite la ricerca di trovare qualcosa di cui ha bisogno per un tempo limitato nella sua città o nel luogo che preferisce e gli annunci saranno filtrati di conseguenza.



# Salve Ragazzi!!!
Ho aggiunto più o meno tutto ciò che ci serve per incominciare a lavorare.
So che molti si sono un pò stressati poichè non sicuri di quello che bisogna fare, ma non preoccupatevi! Passo per passo (e riunione per riunione), finiremo il prodotto.

Presentazioni terminate, vi indico la struttura della repo:

* Nella cartella "logs" ho messo il backlog e un resoconto che verrà aggiornato di riunione in riunione
* Nella cartella "mockup" ci sta il prototipo dell'app (da usare come immagini di riferimento)
* La cartella "rentx\_app" conterrà invece i file dell'applicazione. Al momento è presente l'intera Soluzione di VS (il che non va affatto bene), appena sarò riuscito a studiarmi come settare il git per bene (con i giusti .gitignore) sostituirò quest'ultima con solo i progetti necessari per evitare mal di testa durante la build.

## Come funziona il git workflow
Avrete sicuramente bisogno di lavorare su un vostro pezzo di codice: invece di mettere mano al master fate così

1. Create un vostro `branch` (remoto) che indichi la specificità del vostro obiettivo (potrebbe essere relativo a voi, o magari a una feature, o magari ad entrambi!)
2. Fate il `pull` sulla vostra repo locale 
3. Passate (`checkout`) al vostro `branch` 
4. Fate tutto il lavoro che volete (`git add` -> `git commit` ecc. ecc.)
5. Pushate _**SOLO**_ sul vostro `branch` e solo quando siete sicuri

# NON PUSHATE MAI SUL MASTER A MENO CHE NON NE ABBIATE PARLATO CON TUTTI!!! 
_**(o a meno che non doveste cambiare solo qualche stupidaggine)**_

Detto ciò consiglio pure di fare piccoli `commit`, il più spesso possibile (meglio un `commit` in più che un pezzo di codice in meno)

## Pushare o non pushare, questo è il problema
Ogni volta che vi trovate a pushare un progetto, cartella, file ecc. ecc. su remoto, fate attenzione ad eventuali temp, dotfiles, e file di configurazione legati al pc su cui sviluppate. Questi potrebbero essere difficili da "pulire" dalla propria repo locale. Per ovviare a ciò, controllate se il .gitignore include già la configurazione legata al vostro editor preferito (ad esempio, visual studio), e pushate il tutto assieme.
Ecco un utilissimo tool che compone .gitignore differenti: https://www.gitignore.io/

Buon lavoro e a presto!!! 
