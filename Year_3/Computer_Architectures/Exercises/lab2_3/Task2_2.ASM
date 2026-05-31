	jmp start
	db 5A
	db 3C

start:	
	; TODO
	    MOV AL, [02]
	    MOV BL, [03]
	    ADD AL, BL
	    end