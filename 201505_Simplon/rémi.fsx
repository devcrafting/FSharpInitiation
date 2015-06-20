#r "../Naudio"

open NAudio.Midi
open System.Threading

let MidiOut = new MidiOut(0)

let StartNote note = MidiOut.Send(MidiMessage.StartNote(note,120,1).RawData)
let StopNote note = MidiOut.Send(MidiMessage.StopNote(note,0,1).RawData)

let PlayNote note =
    StartNote note
    Thread.Sleep 500
    StopNote note

PlayNote 120
PlayNote 120
PlayNote 120
PlayNote 122
PlayNote 124