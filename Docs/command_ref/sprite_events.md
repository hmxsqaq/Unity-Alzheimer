# Sprite event handlers # {#sprite_events}

[TOC]
# Object Clicked # {#ObjectClicked}
The block will execute when the user clicks or taps on the clickable object.

Defined in Fungus.ObjectClicked

Property | Type | Description
 --- | --- | ---
Clickable Object | Fungus.Clickable2D | Object that the user can click or tap on
Wait Frames | System.Int32 | Wait for a number of frames before executing the block.
Suppress Block Auto Select | System.Boolean | If true, the flowchart window will not auto select the Block when the Event Handler fires. Affects Editor only.

# Drag Cancelled # {#DragCancelled}
The block will execute when the player drags an object and releases it without dropping it on a target object.

Defined in Fungus.DragCancelled

Property | Type | Description
 --- | --- | ---
Draggable Objects | System.Collections.Generic.List`1[Fungus.Draggable2D] | Draggable object to listen for drag events on
Suppress Block Auto Select | System.Boolean | If true, the flowchart window will not auto select the Block when the Event Handler fires. Affects Editor only.

# Drag Exited # {#DragExited}
The block will execute when the player is dragging an object which stops touching the target object.

Defined in Fungus.DragExited

Property | Type | Description
 --- | --- | ---
Draggable Object | Fungus.Draggable2D | Draggable object to listen for drag events on
Target Object | UnityEngine.Collider2D | Drag target object to listen for drag events on
Suppress Block Auto Select | System.Boolean | If true, the flowchart window will not auto select the Block when the Event Handler fires. Affects Editor only.

# Drag Entered # {#DragEntered}
The block will execute when the player is dragging an object which starts touching the target object.

Defined in Fungus.DragEntered

Property | Type | Description
 --- | --- | ---
Draggable Object | Fungus.Draggable2D | Draggable object to listen for drag events on
Target Object | UnityEngine.Collider2D | Drag target object to listen for drag events on
Suppress Block Auto Select | System.Boolean | If true, the flowchart window will not auto select the Block when the Event Handler fires. Affects Editor only.

# Drag Completed # {#DragCompleted}
The block will execute when the player drags an object and successfully drops it on a target object.

Defined in Fungus.DragCompleted

Property | Type | Description
 --- | --- | ---
Draggable Object | Fungus.Draggable2D | Draggable object to listen for drag events on
Target Object | UnityEngine.Collider2D | Drag target object to listen for drag events on
Suppress Block Auto Select | System.Boolean | If true, the flowchart window will not auto select the Block when the Event Handler fires. Affects Editor only.

# Drag Started # {#DragStarted}
The block will execute when the player starts dragging an object.

Defined in Fungus.DragStarted

Property | Type | Description
 --- | --- | ---
Suppress Block Auto Select | System.Boolean | If true, the flowchart window will not auto select the Block when the Event Handler fires. Affects Editor only.

Auto-Generated by Fungus.ExportReferenceDocs