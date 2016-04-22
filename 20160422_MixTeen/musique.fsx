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
let La = 61
let Si = 63
let Do' = Do + 12
let Re' = Re + 12
let Mi' = Mi + 12
let Fa' = Fa + 12
commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre croche
commencer Do
attendre croche
commencer Do
attendre croche

commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre croche
commencer Do
attendre croche
commencer Do
attendre croche

commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre noire
commencer Do
attendre croche
commencer Do
attendre noire
commencer Do
attendre noirepointee
commencer Re
attendre croche
commencer Sol
attendre croche

commencer La
attendre noire
commencer La
attendre noire
commencer La
attendre croche
commencer Si
attendre croche
commencer Do'
attendre noire
commencer Do'
attendre noire
commencer Do'
attendre croche
commencer Re'
attendre croche
commencer Si
attendre noire
commencer Si
attendre noire
commencer La
attendre croche
commencer Sol
attendre croche
commencer Sol
attendre croche
commencer La
attendre croche
attendre noire
commencer Mi
attendre croche
commencer Sol
attendre croche

commencer La
attendre noire
commencer La
attendre noire
commencer La
attendre croche
commencer Si
attendre croche
commencer Do'
attendre noire
commencer Do'
attendre noire
commencer Do'
attendre croche
commencer Re'
attendre croche
commencer Si
attendre noire
commencer Si
attendre noire
commencer La
attendre croche
commencer Sol
attendre croche
commencer La
attendre croche
attendre croche
attendre noire
commencer Mi
attendre croche
commencer Sol
attendre croche

commencer La
attendre noire
commencer La
attendre noire
commencer La
attendre croche
commencer Si
attendre croche
commencer Re'
attendre noire
commencer Mi'
attendre noire
commencer Mi'
attendre noire
commencer Mi'
attendre croche
commencer Fa'
attendre croche
