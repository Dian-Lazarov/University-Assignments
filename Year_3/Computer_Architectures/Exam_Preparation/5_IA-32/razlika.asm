TITLE Task5_4     (Task5_4.asm)

; This program subtracts the elements of a double word array sequentially
INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
dwArray DWORD 10000h, 20000h, 30000h, 40000h

.code
main PROC
    MOV ECX, LENGTHOF dwArray   ; ECX = 4 (общ брой елементи)
    DEC ECX                     ; ECX = 3 (остават 3 елемента за изваждане)
    
    MOV ESI, TYPE dwArray       ; ESI = 4 (насочваме указателя към ВТОРИЯ елемент)
    MOV EAX, dwArray[0]         ; EAX = 10000h (зареждаме първия елемент като база)

next:   
    SUB EAX, dwArray[ESI]       ; Изваждаме текущия елемент: EAX = EAX - dwArray[ESI]
    ADD ESI, TYPE dwArray       ; Местим указателя с 4 байта напред към следващия елемент
    DEC ECX                     ; Намаляваме брояча на оставащите елементи
    JNZ next                    ; Ако ECX не е 0, повтаряме цикъла

    call DumpRegs               ; Показваме състоянието на регистрите (EAX ще съдържа резултата)
    exit
main ENDP
END main