
// Initialisera "Tillbaka till toppen"-knapp
window.initScrollTopButton = function () {
    const scrollBtn = document.getElementById('scrollTopBtn');
    if (!scrollBtn) {
        console.error("scrollTopBtn element not found!");
        return;
    }

    window.addEventListener('scroll', function () {
        const scrollPosition = window.scrollY || document.documentElement.scrollTop;

        if (scrollPosition > 300) {
            scrollBtn.classList.remove('d-none');
        } else {
            scrollBtn.classList.add('d-none');
        }
    });

    // Trigga manuellt för att kontrollera initial status
    const initialScroll = window.scrollY || document.documentElement.scrollTop;
    if (initialScroll > 300) {
        scrollBtn.classList.remove('d-none');
    }
};