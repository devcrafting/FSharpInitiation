#r "../NAudio.dll"

open NAudio.Midi

let midiOut = new MidiOut(0)

let commencer note = midiOut.Send(MidiMessage.StartNote(note, 127, 1).RawData)
let arreter note = midiOut.Send(MidiMessage.StopNote(note, 0, 1).RawData)
let attendre (duree:int) = System.Threading.Thread.Sleep(duree)

let noire = 250
let croche = noire / 2
let noirepointee = noire + croche

let Do = 52
let Re = 54
let Mi = 56
let Fa = 57
let Sol = 59
let SolDiese = 60
let La = 61
let Si = 63
let Do' = Do + 12
let Re' = Re + 12
let Mi' = Mi + 12
let Fa' = Fa + 12
let Sol' = Sol + 12
let Soupir = 0

let append liste1 liste2 = List.append liste2 liste1

let reprise =
  [[ La, noire; La, noire; La, croche; Si, croche; Do', noire; Do', noire; Do', croche; Re', croche; Si, noire; Si, noire; La, croche; Sol, croche; Sol, croche; La, croche; Soupir, noire; Mi, croche; Sol, croche ];
  [ La, noire; La, noire; La, croche; Si, croche; Do', noire; Do', noire; Do', croche; Re', croche; Si, noire; Si, noire; La, croche; Sol, croche; La, croche; Soupir, noirepointee; Mi, croche; Sol, croche ];
  [ La, noire; La, noire; La, croche; Do', croche; Re', noire; Re', noire; Re', croche; Mi', croche; Fa', noire; Fa', noire; Mi', croche; Re', croche; Mi', croche; La, croche; Soupir, noire; La, croche; Si, croche; Do', noire; Do', noire; Re', noire; Mi', croche; La, croche; Soupir, noire; La, croche; Do', croche ];]
let blindTest =
  [[ La, noire; La, croche; La, noire; La, croche; La, noire; La, croche; La, croche; La, croche; La, croche ];
  [ La, noire; La, croche; La, noire; La, croche; La, noire; La, croche; La, croche; La, croche; La, croche ];
  [ La, noire; La, croche; La, noire; La, croche; La, noire; La, noirepointee; Re, croche; Sol, croche ]]
  |> append reprise
  |> append [[ Si, noire; Si, noire; Do', croche; La, croche; Si, croche; Soupir, noirepointee; Mi, croche; Sol, croche; ]]
  |> append reprise
  |> append [
    [Si, noire; Si, noire; La, croche; SolDiese, croche; La, noire; La, noire; Si, noire; ];
    [Do', noire; Do', noire; Re', noire; Mi', noirepointee; Soupir, croche; Do', croche; La, croche; Mi, noirepointee; Soupir, noirepointee; Fa', noirepointee; Soupir, croche; Re', croche; La, croche ];
    [Fa, noirepointee]]

let jouerNote note =
  let ton, duree = note
  commencer ton
  attendre duree

let jouerLigne ligne =
  ligne
  |> List.iter jouerNote

let jouer partition =
  partition
  |> List.iter jouerLigne

jouer blindTest

jouer reprise
