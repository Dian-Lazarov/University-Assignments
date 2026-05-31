TITLE Program Template     (template.asm)

; Program Description:
; Author:
; Date Created:
; Last Modification Date:

INCLUDE Irvine32.inc
INCLUDE Macros.inc

; (insert symbol definitions here)

.data

; (insert variables here)

.code
main PROC

; (insert executable instructions here)


    call DumpRegs   ; display the registers
    exit            ; exit to operating system
main ENDP

; (insert additional procedures here)

END main