import sys
from PyQt5.QtWidgets import QApplication, QWidget, QVBoxLayout, QLabel, QPushButton

class MainWindow(QWidget):
    count = 0  # Class-level variable to keep track of the count
    
    def __init__(self):
        super().__init__()

        # Set up the window
        self.setWindowTitle("PyQt5 App")
        self.resize(400, 300)

        # Create a label and a button
        self.label = QLabel("Welcome to PyQt5 on Linux!")
        self.button = QPushButton("Click Me")

        # Set up the layout and add widgets
        layout = QVBoxLayout()
        layout.addWidget(self.label)
        layout.addWidget(self.button)

        # Set layout to the window
        self.setLayout(layout)

        # Connect the button's click signal to a method
        self.button.clicked.connect(self.on_button_click)

    def on_button_click(self):
        # Increment the count and update the label
        MainWindow.count += 1  # Increment the class-level count
        self.label.setText(f"Button Clicked! Count: {MainWindow.count}")

# Main entry point of the application
if __name__ == '__main__':
    app = QApplication(sys.argv)

    # Create the main window and show it
    window = MainWindow()
    window.show()

    # Run the application event loop
    sys.exit(app.exec_())
