module Main

open Feliz
open App
open Browser.Dom
open Fable.Core.JsInterop
open Antidote.FormStudio.DynamicFormDesigner
    
importSideEffects "../node_modules/bulma/css/bulma.min.css"
let root = ReactDOM.createRoot(document.getElementById "feliz-app")
root.render(
    
    DynamicFormDesigner StandAlone
    // Antidote.FormStudio.DynamicFormDesigner.DynamicFormDesigner  {|
    //     FormStudioFieldTools = fun _ -> () // ReactElement -> unit
    //     FormStudioPropertyEditor = fun _ -> () // ReactElement -> unit
    //     SetFormStudioPropertyEditorActive = fun () -> () //unit -> unit
    // |}
)