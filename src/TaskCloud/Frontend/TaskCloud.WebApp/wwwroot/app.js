function initializeComponent() {
    console.log('Blazor component has been initialized!');
    // Aquí puedes agregar más lógica de inicialización
}

// Asegúrate de que esta función esté disponible globalmente
window.initializeComponent = initializeComponent;

function InitializeSplitContainer() {
    console.log("InitializeSplitContainer...");
    const resizer = document.querySelector('.resizer');
    const topPane = document.querySelector('.top-pane');
    const bottomPane = document.querySelector('.bottom-pane');

    if (!resizer || !topPane || !bottomPane) {
        console.error('One or more elements not found.');
    }

    let isResizing = false;

    resizer.addEventListener('mousedown', function (e) {
        isResizing = true;
        document.addEventListener('mousemove', handleMouseMove);
        document.addEventListener('mouseup', handleMouseUp);
    });

    function handleMouseMove(e) {
        if (isResizing) {
            const containerRect = document.querySelector('.container').getBoundingClientRect();
            const newTopPaneHeight = e.clientY - containerRect.top;
            topPane.style.height = `${newTopPaneHeight}px`;
        }
    }

    function handleMouseUp() {
        isResizing = false;
        document.removeEventListener('mousemove', handleMouseMove);
        document.removeEventListener('mouseup', handleMouseUp);
    }
}