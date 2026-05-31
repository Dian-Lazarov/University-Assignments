INCLUDE Irvine32.inc
INCLUDE Macros.inc

.data
dwArray DWORD 13h,55h,55h,55h

.code
main PROC
    ; TODO:
    	; EAX (Буфер за данни): Зарежда текущия елемент от масива, за да бъде сравнен с 55h.
    	; EBX (Резултат / Брояч): В него ще натрупваме броя на елементите, които отговарят на даденото условие. Първоначално се нулира.
    	; ESI (Индекс / Указател): Пази адреса на текущия елемент в паметта. Увеличава се с размера на данните (TYPE dwArray = 4 байта).
	; ECX (Брояч на цикъла): Зарежда се с общия брой елементи (LENGTHOF) и се намалява до 0, за да следи кога масивът свършва.
    
    	MOV EBX, 0
	MOV ESI, OFFSET dwArray
	MOV ECX, LENGTHOF dwArray
next:
	MOV EAX, [ESI]
	CMP EAX, 55h
	JC count_it
	JZ count_it
	JMP skip
count_it:
	INC EBX
skip:
	ADD ESI, type dwArray
	DEC ECX
	JNZ next
	
ShowRegister RESULT, EBX

    exit
main ENDP
END main