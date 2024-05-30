
export const filtersInitialState:{ [key: string]: string } = {
    'CLOTHING': '',
    'EYES': '',
    'FACE': '',
    'SKIN': '',
    'BACKGROUND': '',
    'SPECIAL': '',
    'SEARCH': ''
};

export const toQueryString = (filters:{ [key: string]: string }): string => {
    return Object.entries(filters)
        .filter(([, value]) => value !== '')
        .map(([key, value]) => `${encodeURIComponent(key.toLowerCase())}=${encodeURIComponent(value)}`)
        .join('&');
}