var submitionPage;


async function decline() {
    submitionPage.style.display = 'none';
}

async function accept() {
    submitionPage.style.display = 'none';
}


async function show(ID) {
    submitionPage = document.getElementById('submition-' + ID);
    submitionPage.style.display = 'block';
}