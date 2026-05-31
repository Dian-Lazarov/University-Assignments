jmp start
	db 3F
	db 67
	db 0A
	db FA
	db 07
	db 55
	db 55
	db 55
	db 55
	db 55
cnt:
	db 00	; клетка за резултата

; Разпределение на работните регистри
; AL - буферен регистър
; CL - резултат
; DL - индексен регистър за достъп до масива

start:
      	MOV CL, 0
	MOV DL, 02
next:
	MOV AL, [DL]
	CMP AL, 55
	JNZ skip
	INC CL
skip:
	INC DL
	CMP DL, 0C
	JNZ next
	MOV [0C], CL
halt
end