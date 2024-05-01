Exploratory repo for blazor, speech-to-text-to-speech, and possibly AI.

Mostly for kicks, but main long term goal is to get a blazor app that will be a sort of terse vesion of alexa/siri/etc.


Current Short/Mid TODO List
---------------------------

Get POST handling of requests - it doesn't look like the javascript post send is makign it into the SaveAudio.cs - probably due to difference in blazor versions between this and template project
https://stackoverflow.com/questions/66941052/post-form-data-to-blazor-razor-component-application-x-www-form-urlencoded

Get POST handling to handle audio in memory without doing any saves

Or work on how to read BLOB object from blazor side.  Looks like I can reference the blob in the recorder.export function



Look into NuGet audio-to-text libraries.

Note to self: Visualizer has real-time sound info, so I might be able to get audio without explicit record operation?


