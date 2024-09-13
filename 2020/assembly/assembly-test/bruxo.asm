section .data
	text db "Fala Jean seu viado!",10
section .text
	global _start
_start:
	mov rax, 1
	mov rdi, 1
	mov rsi, text
	mov rdx, 19
	syscall

	mov rax, 60
	mov rdi, 0
	syscall
