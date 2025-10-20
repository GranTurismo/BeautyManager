let currentModalInstance;

function hideModal(id)
{
        currentModalInstance = bootstrap.Modal.getInstance(document.getElementById(id));
        if(currentModalInstance!=undefined)
            currentModalInstance.hide();
}

function showModal(id) {
    const el = document.getElementById(id);
    if (!el) return;
    const modal = new bootstrap.Modal(el,{
        keyboard: false,
        backdrop:'static'
    });
    modal.show();
}
