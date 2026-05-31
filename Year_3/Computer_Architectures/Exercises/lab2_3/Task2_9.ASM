	MOV AL, 00	; AL Ц сума

	MOV BL, 1	; бро€ч

sum_loop:
	ADD AL, BL
	CMP BL, 0A	; 0A = 10
	JZ finish
	INC BL
	JMP sum_loop
finish:
	END