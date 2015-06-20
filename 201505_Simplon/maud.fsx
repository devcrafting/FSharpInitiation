#r "../NAudio"

open NAudio.Midi
open System.Threading

let MidiOut = new MidiOut(0)
 
let startNote note = MidiOut.Send(MidiMessage.StartNote(note,120,1).RawData)
let stopNote note = MidiOut.Send(MidiMessage.StopNote(note,0,1).RawData)

let playNote note =
    startNote note
    Thread.Sleep 500
    stopNote note
 
playNote 60
playNote 60
playNote 60
playNote 62
playNote 64