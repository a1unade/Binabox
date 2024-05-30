import {errorMessages} from '../types/messages/errorMessages.ts'

// Валидатор для проверки почты
export const validateEmail = (email: string): string => {
    const emailRegex: RegExp = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (email.length === 0) return errorMessages.emptyEmail;
    if (!emailRegex.test(email)) return errorMessages.invalidEmail;

    return '';
}

// Валидатор для проверки никнейма
export const validateNickname = (nickname: string): string => {
    const nameRegex: RegExp = /^[a-zA-Z\u0400-\u04FF]+$/;

    if (nickname.length === 0) return errorMessages.emptyNickname;
    if (!nameRegex.test(nickname)) return errorMessages.invalidNickname;

    return '';
}

// Валидатор для проверки пароля
export const validatePassword = (password: string): string => {
    if (password.length < 8 || password.length > 12) return errorMessages.passwordLength;

    const hasUpperCase: boolean = /[A-Z]/.test(password);
    const hasLowerCase: boolean = /[a-z]/.test(password);
    const hasDigits: boolean = /\d/.test(password);
    const hasSpecialChars: boolean = /[!@#$%]/.test(password);

    if (!hasUpperCase || !hasLowerCase || !hasDigits || !hasSpecialChars) {
        if (!hasUpperCase) return errorMessages.passwordUpperCase;
        if (!hasLowerCase) return errorMessages.passwordLowerCase;
        if (!hasDigits) return errorMessages.passwordDigits;
        if (!hasSpecialChars) return errorMessages.passwordSpecialChars;
    }

    return '';
}