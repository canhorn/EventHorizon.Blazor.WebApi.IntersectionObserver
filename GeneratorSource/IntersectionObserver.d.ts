class IntersectionObserver {
    readonly root: Element | Document | null;
    readonly rootMargin: string;
    readonly thresholds: number;
    disconnect(): void;
    observe(target: Element): void;
    takeRecords(): IntersectionObserverEntry[];
    unobserve(target: Element): void;
    constructor(callback: (entries: IntersectionObserverEntry[], observer: IntersectionObserver) => void, options?: IntersectionObserverInit);
}

class IntersectionObserverEntry {
    readonly boundingClientRect: DOMRectReadOnly;
    readonly intersectionRatio: number;
    readonly intersectionRect: DOMRectReadOnly;
    readonly isIntersecting: boolean;
    readonly rootBounds: DOMRectReadOnly | null;
    readonly target: Element;
    readonly time: number;
    constructor(intersectionObserverEntryInit: IntersectionObserverEntryInit);
}

interface IntersectionObserverEntryInit {
    boundingClientRect: DOMRectInit;
    intersectionRatio: number;
    intersectionRect: DOMRectInit;
    isIntersecting: boolean;
    rootBounds: DOMRectInit | null;
    target: Element;
    time: number;
}

interface IntersectionObserverInit {
    root?: Element | Document | null;
    rootMargin?: string;
    threshold?: number | number[];
}

interface DOMRectInit {
    height?: number;
    width?: number;
    x?: number;
    y?: number;
}

interface DOMRectReadOnly {
    readonly bottom: number;
    readonly height: number;
    readonly left: number;
    readonly right: number;
    readonly top: number;
    readonly width: number;
    readonly x: number;
    readonly y: number;
    toJSON(): any;
}

/**
 * This is the DOM Element, includes only what is needed by the application to function.
 */
class Element {
    id: string;
    innerHTML: string;
    appendChild(child: Element): void;
}
